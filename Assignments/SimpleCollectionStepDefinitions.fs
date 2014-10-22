module SimpleCollectionStepDefinitions

open TickSpec
open NUnit.Framework
open FsUnit

let mutable simpleCollection:int list = []
let mutable resultSet:int list = [] 

let [<Given>] ``a collection from (.*) to (.*)`` (start:int)(en:int) = 
    simpleCollection <- [start..en]
      
let [<When>] ``I ask if the collection has items divisible by (.*)`` (n:int) =  
    //TODO: Add your code here to populate the result set with numbers divisble by 'n'
    let boom= simpleCollection |>  List.filter (fun x -> x % n = 0) 
    resultSet <- boom
   
      
let [<Then>] ``the result set length should be (.*)`` (len:int) =  
    Assert.AreEqual(len,resultSet.Length)

let [<Then>] ``the set should contain (.*)`` (expected:int) =  
    let doesExist=resultSet|> List.exists (fun x-> x= expected)
    Assert.IsTrue(doesExist, "Could not find it")