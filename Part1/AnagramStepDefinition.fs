module AnagramStepDefinition

open TickSpec
open NUnit.Framework
open FsUnit

let isAnAnagram str = 
  // todo: implement algorithm that returns true or false if string 'str' is an anagram
  // hint: http://en.wikipedia.org/wiki/Anagram
  false

let mutable storedString = ""

let [<Given>] ``a string (.*)`` (str:string)= 
    storedString <- str
      
let [<When>] ``I check if its an anagram`` () =  
    ()   

let [<Then>] ``the answer should be false (.*)`` (expected:bool) =  
    let res = isAnAnagram storedString
    Assert.AreEqual(expected,res)
