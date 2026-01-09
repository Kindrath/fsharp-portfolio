module fsharpPortfolioTests.Week1Tests

open Expecto
open fsharpPortfolio.Week1

[<Tests>]
let tests =
    testList "Week 1 Tests" [
        testCase "testValue should be 2" <| fun _ ->
            Expect.equal testValue 2 "testValue is not equal to 2"
    ]
