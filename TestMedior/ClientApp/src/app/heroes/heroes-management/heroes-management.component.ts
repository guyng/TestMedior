import { getMyHeroes, getAllHeroes } from './../../shared/store/heroes.selectors';
import { fetchAllHeroes, fetchMyHeroes } from './../../shared/store/heroes.actions';
import { HeroesState } from './../../shared/store/heroes.reducers';
import { HeroService } from '../../shared/services/hero.service';
import { Component } from '@angular/core';
import { Hero } from 'src/app/shared/models/hero.model';
import { Store } from '@ngrx/store';

@Component({
  selector: 'heroes-management',
  styleUrls: ['./heroes-management.component.scss'],
  templateUrl: './heroes-management.component.html'
})
export class HeroesManagementComponent {
  selectedDate;
  compareFunction = (o1: any, o2: any) => o1.id === o2.id;
  myHeroes: Hero[];
  othersHeroes: Hero[];
  allHeroes: Hero[];
  constructor(private heroes_store: Store<HeroesState>) {
    this.heroes_store.dispatch(fetchMyHeroes())
    this.heroes_store.dispatch(fetchAllHeroes());
    this.heroes_store.select(getMyHeroes).subscribe(mh => {
      if (mh){
        this.myHeroes = mh;
        if (this.allHeroes){
          this.setOtherHeroes();
        }
      }
    })
    this.heroes_store.select(getAllHeroes).subscribe(ah => {
      if (ah){
        this.allHeroes = ah;
        if (this.myHeroes){
          this.setOtherHeroes();
        }
      }
    })
  }

  private setOtherHeroes() {
    this.othersHeroes = this.allHeroes.filter(hero => !this.myHeroes.find(myHero => myHero.id == hero.id));
  }
}
