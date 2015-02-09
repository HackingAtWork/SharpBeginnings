module LeapYearStepDefinition

open TickSpec
open NUnit.Framework
open FsUnit

let mutable storedYear=0

let isLeapYear (year:int) = 
  false

let [<Given>] ``the year (.*)`` (year:int)= 
    storedYear <- year
      
let [<When>] ``I do my leap year detemination`` () =  
    ()   

let [<Then>] ``I shall find that it is not a leap year`` () =  
    let res = isLeapYear storedYear
    Assert.IsFalse(res)

let [<Then>] ``I shall find that it is a leap year`` () =  
    let res = isLeapYear storedYear
    Assert.IsTrue(res)