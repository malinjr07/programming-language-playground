import type { HardhatUserConfig } from "hardhat/config";

import hardhatToolboxMochaEthersPlugin from "@nomicfoundation/hardhat-toolbox-mocha-ethers";
import { configVariable } from "hardhat/config";

const config: HardhatUserConfig = {
  plugins: [hardhatToolboxMochaEthersPlugin],
  solidity: {
    profiles: {
      default: {
        version: "0.8.28",
      },
      production: {
        version: "0.8.28",
        settings: {
          optimizer: {
            enabled: true,
            runs: 200,
          },
        },
      },
    },
  },
  networks: {
    hardhatMainnet: {
      // Local Hardhat network with mainnet fork
      type: "edr-simulated", // EDR (Ethereum Development Runtime) simulation
      chainType: "l1", // Layer 1 chain
    },
    hardhatOp: {
      // Local Hardhat network with Optimism fork
      type: "edr-simulated", // EDR simulation
      chainType: "op", // Optimism chain
    },
    sepolia: {
      // Sepolia testnet configuration
      type: "http", // RPC type
      chainType: "l1", // Layer 1 chain
      url: configVariable("SEPOLIA_RPC_URL"), // RPC URL from environment
      accounts: [configVariable("SEPOLIA_PRIVATE_KEY")], // Private keys
    },
  },
};

export default config;
