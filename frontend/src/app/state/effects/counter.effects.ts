import { Injectable } from "@angular/core";
import { Actions } from "@ngrx/effects";
import { createEffect } from "@ngrx/effects/src";
import { tap } from "rxjs";

@Injectable()
export class CounterEffects {


    logItall$ = createEffect(() => {
        return this.actions$.pipe(
            tap(a => console.log(`Got an action of type ${a.type}`))

        )
    })

    constructor(private actions$: Actions) { }
}