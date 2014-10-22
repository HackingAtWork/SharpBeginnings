module SimpleCollectionStepDefinitions

open TickSpec
open NUnit.Framework
open FsUnit

let mutable simpleCollection = []
let mutable numberToEvaluate = 0

let [<Given>] ``a collection from (.*) to (.*)`` (start:int)(en:int) = 
    simpleCollection<-[start..en]
      
let [<When>] ``I ask what number (.*) is`` (n:int) =  
    numberToEvaluate <- n
      
let [<Then>] ``It should say it is (.*)`` (res:string) =  
//Your code here   
    let actual = "odd"
    Assert.AreEqual(res,actual)