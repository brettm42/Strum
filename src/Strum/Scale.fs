namespace Strum

[<AutoOpen>]
module Scale =
    open System
        
    let C n = 12 * n
    let D n = C n + 2
    let E n = C n + 4
    let F n = C n + 5
    let G n = C n + 7
    let A n = C n + 9
    let B n = C n + 11

    let flat n = n - 1
    let sharp n = n + 1
        
    let Cb = C >> flat
    let ``C#`` = C >> sharp
    let Db = D >> flat
    let ``D#`` = D >> sharp
    let Eb = E >> flat
    let ``E#`` = E >> sharp
    let Fb = F >> flat
    let ``F#`` = F >> sharp
    let Gb = G >> flat
    let ``G#`` = G >> sharp
    let Ab = A >> flat
    let ``A#`` = A >> sharp
    let Bb = B >> flat
    let ``B#`` = B >> sharp
    