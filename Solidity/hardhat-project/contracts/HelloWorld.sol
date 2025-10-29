// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.28;

contract HelloWorld{
    string public message = "Rizu Love!";

    event LogMessage(string message);

    constructor(){
        emit LogMessage(message);
    }

    function hello() public view returns (string memory){
        return message;
    }

    function setMsg(string calldata newMsg) public{
        message = newMsg;
        emit LogMessage(newMsg);
    }
}