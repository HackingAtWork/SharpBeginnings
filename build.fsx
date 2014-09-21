
#r @"packages/FAKE.3.4.3/tools/FakeLib.dll"

open System
open System.IO
open Fake

let buildDir = "./builds"
let assignmentDir= "./builds/assignments/"


Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

Target "BuildAssignments" (fun _ ->
  Console.WriteLine(Directory.GetCurrentDirectory())
  !! ("**/*.fsproj")
    |> MSBuildRelease assignmentDir "Build"
          |> Log "AppBuild-Output: "
)

Target "CheckAssignments" (fun _ ->
    !! (assignmentDir+ "*.Tests.dll")
      |> NUnit (fun p ->
          {p with
             DisableShadowCopy = true;
             OutputFile = assignmentDir + "TestResults.xml" })
)

"Clean"          
  ==> "BuildAssignments" 
  ==> "CheckAssignments" 


RunTargetOrDefault "CheckAssignments"