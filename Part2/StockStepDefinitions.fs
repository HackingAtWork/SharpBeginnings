module StockStepDefinitions

open TickSpec
open NUnit.Framework

let reverse str = 
  //todo: implement algorithm to reverse a string
  //NOTE: do not use Seq, List or Array.reverse for this exercise
  "ti od"

let mutable storedString = ""

let [<Given>] ``a reversable string (.*)`` (str:string)= 
    storedString <- str
      
let [<When>] ``I reverse it`` () = 
    let newStr = reverse storedString
    storedString <- newStr 

let [<Then>] ``the reversed string should be (.*)`` (expected:string) =  
    Assert.AreEqual(expected,storedString)
