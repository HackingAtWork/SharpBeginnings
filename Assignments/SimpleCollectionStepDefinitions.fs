module SimpleCollectionStepDefinitions

open TickSpec
open NUnit.Framework
open FsUnit
open System

let mutable simpleCollection:int list = []
let mutable resultSet:int list = [] 
let mutable sortedSet:int list=[]

let listSorter (listy : int list)=
   //todo: implement sort algorithm
    [0] 

let isDivisbleBy x =
    //TODO: Add your code here
    false

let randomCollection = 
    let rnd = System.Random()
    List.init 15 (fun _ -> rnd.Next ())

let [<Given>] ``a collection from (.*) to (.*)`` (start:int)(en:int) = 
    simpleCollection <- [start..en]
      
let [<When>] ``I ask if the collection has items divisible by (.*)`` (n:int) =  
    let boom= simpleCollection |>  List.filter isDivisbleBy
    resultSet <- boom
      
let [<Then>] ``the result set length should be (.*)`` (len:int) =  
    Assert.AreEqual(len,resultSet.Length)

let [<Then>] ``the set should contain (.*)`` (expected:int) =  
    let doesExist=resultSet|> List.exists (fun x-> x= expected)
    Assert.IsTrue(doesExist, "Could not find it")

let [<Given>] ``a random collection`` () = 
    ()

let [<When>] ``I sort that collection`` () =  
    sortedSet <- (listSorter randomCollection)

let [<Then>] ``the result should be sorted`` () =  
    let expectedSort = List.sort randomCollection
    let res = (set expectedSort = set sortedSet)

    printfn "Expecting:"
    expectedSort |> List.iter (fun x-> printf "%d," x)
    printfn "\n Found:"
    sortedSet |> List.iter (fun x-> printf "%d" x)
    printfn ""
    Assert.IsTrue(res, "Was not sorted well")