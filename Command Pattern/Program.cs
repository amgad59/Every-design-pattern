/*
 * Bank Example on the Command Pattern
 * 
 * 
using Command_Pattern.Command_Pattern.Interfaces;
using Command_Pattern.Command_Pattern;

var ba = new BankAccount();
var cmdDeposit = new BankAccountCommand(ba,
  BankAccountCommand.Action.Deposit, 100);
var cmdWithdraw = new BankAccountCommand(ba,
  BankAccountCommand.Action.Withdraw, 1000);
cmdDeposit.Call();
cmdWithdraw.Call();
Console.WriteLine(ba);
cmdWithdraw.Undo();
cmdDeposit.Undo();
Console.WriteLine(ba);

var from = new BankAccount();
from.Deposit(100);
var to = new BankAccount();

var mtc = new MoneyTransferCommand(from, to, 5);
mtc.Call();


// Deposited $100, balance is now 100
// balance: 100
// balance: 0

Console.WriteLine(from);
Console.WriteLine(to);*/