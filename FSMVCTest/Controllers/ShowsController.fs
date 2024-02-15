namespace FSMVCTest.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open System.Diagnostics

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

open FSMVCTest.Models

type ShowController() =
    inherit Controller()
    member this.Index() = this.View("Index")