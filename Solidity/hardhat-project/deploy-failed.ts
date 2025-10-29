const hre = require("hardhat");

async function main() {
  const Hello = await hre.ethers.getContractFactory("HelloWorld");
  const hello = await Hello.deploy();
  await hello.deployed();
  console.log("Deployed at:", hello.address);
  console.log("hello()", await hello.hello());
}

main()
  .then(() => process.exit(0))
  .catch((err) => {
    console.error(err);
    process.exit(1);
  });
