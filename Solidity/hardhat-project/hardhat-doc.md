# Hardhat Configuration Documentation

## Table of Contents
1. [Configuration Overview](#configuration-overview)
2. [Solidity Compiler Settings](#solidity-compiler-settings)
3. [Network Configuration](#network-configuration)
4. [Directory Structure](#directory-structure)
5. [TypeChain Integration](#typechain-integration)
6. [Environment Variables](#environment-variables)
7. [References](#references)

## Configuration Overview

The `hardhat.config.ts` file is the main configuration file for Hardhat projects. It defines how Hardhat runs tasks, compiles contracts, and connects to different networks.

### Key Components:

```typescript
import type { HardhatUserConfig } from "hardhat/config";
import hardhatToolboxMochaEthersPlugin from "@nomicfoundation/hardhat-toolbox-mocha-ethers";
import { configVariable } from "hardhat/config";

const config: HardhatUserConfig = {
  // Configuration objects go here
};

export default config;
```

## Solidity Compiler Settings

### Profiles

#### Default Profile
```typescript
profiles: {
  default: {
    version: "0.8.28"  // Default Solidity version
  }
}
```
- **Purpose**: Used for development and testing
- **Version**: Specifies the Solidity compiler version

#### Production Profile
```typescript
production: {
  version: "0.8.28",
  settings: {
    optimizer: {
      enabled: true,
      runs: 200,
    },
  },
}
```
- **Purpose**: Optimized settings for production deployments
- **Optimizer**: Reduces gas costs in production
  - `enabled`: Turns the optimizer on/off
  - `runs`: Number of runs for optimization (higher = better runtime gas, higher deployment cost)

### Available Solidity Settings

| Setting | Type | Description | Default |
|---------|------|-------------|---------|
| version | string | Solidity compiler version | - |
| settings.optimizer.enabled | boolean | Enable/disable optimizer | false |
| settings.optimizer.runs | number | Optimize for how many runs | 200 |
| settings.evmVersion | string | Target EVM version | - |
| settings.viaIR | boolean | Use Yul intermediate representation | false |

For complete documentation, see: [Solidity Compiler Documentation](https://docs.soliditylang.org/en/latest/using-the-compiler.html)

## Network Configuration

### Network Types

#### 1. EDR-Simulated Networks
```typescript
hardhatMainnet: {
  type: "edr-simulated",  // Ethereum Development Runtime
  chainType: "l1",        // Layer 1 chain
}
```
- **Purpose**: Local development with mainnet state
- **Use Case**: Testing against mainnet state without real transactions

#### 2. HTTP Networks
```typescript
sepolia: {
  type: "http",
  chainType: "l1",
  url: configVariable("SEPOLIA_RPC_URL"),
  accounts: [configVariable("SEPOLIA_PRIVATE_KEY")],
}
```
- **Purpose**: Connect to external networks
- **Authentication**: Requires RPC URL and private keys

### Available Networks

| Network Name | Type | Chain Type | Description |
|--------------|------|------------|-------------|
| hardhatMainnet | edr-simulated | l1 | Local mainnet fork |
| hardhatOp | edr-simulated | op | Local Optimism fork |
| sepolia | http | l1 | Sepolia testnet |

## Directory Structure

```typescript
paths: {
  sources: "./contracts",  // Solidity source files
  tests: "./test",         // Test files
  cache: "./cache",        // Compiled cache
  artifacts: "./artifacts", // Compiled contracts
}
```

## TypeChain Integration

```typescript
typechain: {
  outDir: "typechain-types",  // Output directory
  target: "ethers-v6",        // Target library
}
```

## Environment Variables

Required environment variables (store in `.env` file):

```env
SEPOLIA_RPC_URL=your_rpc_url_here
SEPOLIA_PRIVATE_KEY=your_private_key_here
```

## References

1. [Hardhat Documentation](https://hardhat.org/docs)
2. [Solidity Documentation](https://docs.soliditylang.org/)
3. [Ethereum Development with Hardhat](https://hardhat.org/getting-started/)
4. [Hardhat Network Reference](https://hardhat.org/hardhat-network/docs/reference)

## Keeping Updated

To stay current with the latest Hardhat features and best practices:
- Follow [Hardhat GitHub Repository](https://github.com/NomicFoundation/hardhat)
- Check [Hardhat Release Notes](https://github.com/NomicFoundation/hardhat/releases)
- Join the [Hardhat Discord](https://hardhat.org/discord) community
