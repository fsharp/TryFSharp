module Widgets.About

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma
open Fable.Repl.Shared

let view =
    Content.content [ ]
        [ a [ Href "https://fable.io/repl" ]
            [ Text.span [ Modifiers [ Modifier.TextTransform TextTransform.Italic ]
                          Props [ Style [ TextDecoration "underline" ] ] ]
                [ str "Based on Fable 2 REPL" ] ]
          br [ ]
          str ("Version: " + Literals.VERSION)
          br [ ]
          a [ Href "https://github.com/LambdaFactory/TryFSharp/issues/new" ]
            [ Text.span [ Modifiers [ Modifier.TextTransform TextTransform.Italic ]
                          Props [ Style [ TextDecoration "underline" ] ] ]
                [ str "Found a bug ?" ] ] ]
