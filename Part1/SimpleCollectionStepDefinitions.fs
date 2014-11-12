module SimpleCollectionStepDefinitions

open TickSpec
open NUnit.Framework
open FsUnit
open System

let mutable simpleCollection:int list = []
let mutable resultSet:int list = [] 

let isDivisbleBy number divisibleBy =
    //TODO: Add code to check if 'number' can be evenly divided by 'divisibleBy'
    false

let [<Given>] ``a collection from (.*) to (.*)`` (start:int)(en:int) = 
    simpleCollection <- [start..en]
      
let [<When>] ``I ask if the collection has items divisible by (.*)`` (divisibleBy:int) =  
    let boom= simpleCollection |>  List.filter (fun x -> isDivisbleBy x divisibleBy)
    resultSet <- boom
      
let [<Then>] ``the result set length should be (.*)`` (len:int) =  
    Assert.AreEqual(len,resultSet.Length)

let [<Then>] ``the result set should contain (.*)`` (expected:int) =  
    let doesExist=resultSet|> List.exists (fun x-> x= expected)
    Assert.IsTrue(doesExist, "Could not find it")