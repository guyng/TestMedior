import { fetchMyHeroes, fetchAllHeroesSuccess, fetchMyHeroesFailure, fetchAllHeroes, fetchAllHeroesFailure, fetchMyHeroesSuccess, trainHero, trainHeroSuccess, trainHeroFailure } from './heroes.actions';
import { Action, createReducer, on } from '@ngrx/store';
import { Hero } from '../models/hero.model';

export const heroesFeatureKey = 'heroes';

export interface HeroesState {
  myHeroes: Hero[];
  allHeroes: Hero[];
  loading: boolean;
  loaded: boolean;
}

export const initialState: HeroesState = {
  myHeroes: [],
  allHeroes: [],
  loading: false,
  loaded: false
};


export const HeroesReducer = createReducer(
  initialState,

  on(fetchMyHeroes, state =>
  ({
    ...state,
    loading: true,
    loaded: false
  })),
  on(fetchMyHeroesSuccess, (state, { myHeroes }) =>
  ({
    ...state,
    myHeroes,
    loading: false,
    loaded: true
  })
  ),
  on(fetchMyHeroesFailure, (state, action) => ({
    ...state,
    loading: false,
    loaded: false
  })),
  on(fetchAllHeroes, (state,) =>
  ({
    ...state,
    loading: true,
    loaded: false
  })
  ),
  on(fetchAllHeroesSuccess, (state, { allHeroes }) => {
    return ({
      ...state,
      allHeroes,
      loading: false,
      loaded: true
    })
  }),
  on(fetchAllHeroesFailure, (state, action) => ({
    ...state,
    loading: false,
    loaded: false
  })),
  on(trainHero, (state, action) => ({
    ...state,
    loading: true,
    loaded: false
  })),
  on(trainHeroSuccess, (state, { trainedHero }) => {
    var l:any[];
    let myHeroes = JSON.parse(JSON.stringify(state.myHeroes));
    let heroToReplaceIndex = myHeroes.findIndex(mh => mh.id === trainedHero.id);
    if (heroToReplaceIndex > -1){
      myHeroes[heroToReplaceIndex] = trainedHero;
    }
    return ({
      ...state,
      myHeroes,
      loading: false,
      loaded: true
    })
  }),
  on(trainHeroFailure, (state, action) => ({
    ...state,
    loading: false,
    loaded: false
  })),

);

