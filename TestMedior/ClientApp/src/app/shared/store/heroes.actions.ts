import { createAction, props } from "@ngrx/store";
import { Hero } from "../models/hero.model";

export const fetchMyHeroes = createAction(
  '[Pricing] Fetch My Heroes'
);

export const fetchMyHeroesSuccess = createAction(
'[Pricing] Fetch My Heroes Success',
props<{ myHeroes: Hero[] }>()
);

export const fetchMyHeroesFailure = createAction(
'[Pricing] Fetch My Heroes Failure',
props<{ error: any }>()
);

export const fetchAllHeroes = createAction(
  '[Pricing] Fetch My Heroes'
);

export const fetchAllHeroesSuccess = createAction(
'[Pricing] Fetch All Heroes Success',
props<{ allHeroes: Hero[] }>()
);

export const fetchAllHeroesFailure = createAction(
'[Pricing] Fetch All Heroes Failure',
props<{ error: any }>()
);

export const trainHero = createAction(
  '[Pricing] Train Hero',
  props<{ heroId: number }>()
);

export const trainHeroSuccess = createAction(
'[Pricing] Train Hero Success',
props<{ trainedHero: Hero }>()
);

export const trainHeroFailure = createAction(
'[Pricing] Train Hero Failure',
props<{ error: any }>()
);
