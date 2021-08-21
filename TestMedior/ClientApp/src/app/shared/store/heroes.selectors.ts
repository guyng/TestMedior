import { HeroesState, heroesFeatureKey } from './heroes.reducers';
import { createFeatureSelector, createSelector } from '@ngrx/store';

export const selectHeroState = createFeatureSelector<HeroesState>(
  heroesFeatureKey
);

export const getMyHeroes = createSelector(
  selectHeroState,
    (state: HeroesState) => state.myHeroes
);

export const getAllHeroes = createSelector(
  selectHeroState,
    (state: HeroesState) => state.allHeroes
);

export const getHeroesLoading = createSelector(
  selectHeroState,
    (state: HeroesState) => state.loading
);

