namespace Strum

module Console = 
    open System

    [<EntryPoint>]
    let main argv = 
        
        let notes = List.map Note

        let strings = notes [E; A; D; G; B; E;]
        
        printfn "%A" argv
        0 // return an integer exit code
