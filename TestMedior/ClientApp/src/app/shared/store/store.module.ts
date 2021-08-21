import { NgModule } from "@angular/core";
import { EffectsModule } from "@ngrx/effects";
import { StoreModule } from "@ngrx/store";
import { HeroesEffect } from "./heroes.effects";
import { HeroesReducer } from "./heroes.reducers";


@NgModule({
  imports: [
    StoreModule.forRoot({}),
    EffectsModule.forRoot([]),
    StoreModule.forFeature('heroes', HeroesReducer),
    EffectsModule.forFeature([HeroesEffect]),
  ],
  providers: []
})
export class SharedStoreModule {
}
