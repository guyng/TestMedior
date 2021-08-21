import { fetchMyHeroes, fetchMyHeroesSuccess, fetchMyHeroesFailure, fetchAllHeroes, fetchAllHeroesSuccess, fetchAllHeroesFailure, trainHero, trainHeroSuccess, trainHeroFailure } from './heroes.actions';
import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { catchError, map, concatMap, switchMap } from 'rxjs/operators';
import { EMPTY, of } from 'rxjs';
import { HeroService } from '../services/hero.service';

@Injectable()
export class HeroesEffect {

  constructor(private actions$: Actions, private heroService: HeroService) {

  }

  fetchMyHeroes$ = createEffect(() => {
    return this.actions$.pipe(
      ofType(fetchMyHeroes),
      switchMap(() =>
        this.heroService.getMyHeroes()
          .pipe(map(myHeroes => fetchMyHeroesSuccess({ myHeroes })),
            catchError(error => of(fetchMyHeroesFailure({ error })))))
    );
  });

  fetchOthersHeroes$ = createEffect(() => {
    return this.actions$.pipe(

      ofType(fetchAllHeroes),
      switchMap(() =>
        this.heroService.getAllHeroes()
          .pipe(map(allHeroes => fetchAllHeroesSuccess({ allHeroes })),
            catchError(error => of(fetchAllHeroesFailure({ error })))))
    );
  });

  trainHero$ = createEffect(() => {
    return this.actions$.pipe(

      ofType(trainHero),
      switchMap((action) =>
        this.heroService.trainHero(action.heroId)
          .pipe(map(trainedHero => trainHeroSuccess({trainedHero})),
            catchError(error => of(trainHeroFailure({ error })))))
    );
  });
}
