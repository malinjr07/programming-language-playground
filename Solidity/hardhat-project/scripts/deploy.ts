import { network } from "hardhat";

async function main() {
  const { ethers } = await network.connect({
    network: "hardhatOp",
    chainType: "op",
  });

  console.log("Sending transaction using the OP chain type");

  const [deployer] = await ethers.getSigners();
  console.log("Deploying contracts with the account:", deployer.address);

  const HelloWorld = await ethers.getContractFactory("HelloWorld");
  const hello = await HelloWorld.deploy();
  await hello.waitForDeployment(); // Wait for deployment confirmation in Ethers v6

  console.log("HelloWorld deployed to:", await hello.getAddress());
  const helloMessage = await hello.hello();
  console.log("hello() returned:", helloMessage);
}

await main();
