import { trainHero } from './../../shared/store/heroes.actions';
import { HeroService } from '../../shared/services/hero.service';
import { Component, Input } from "@angular/core";
import { Hero } from "src/app/shared/models/hero.model";
import { HeroesState } from 'src/app/shared/store/heroes.reducers';
import { Store } from '@ngrx/store';

@Component({
  selector: 'hero-card',
  styleUrls: ['./hero-card.component.scss'],
  templateUrl: './hero-card.component.html'
})
export class HeroCardComponent {

  @Input()
  hero: Hero;
  @Input()
  disableTrain: boolean = false;
  heroTrainingLoading: boolean = false;

  constructor(private heroService: HeroService
    , private store_shared: Store<HeroesState>) {

  }

  private trainHero(heroId: number) {
    this.store_shared.dispatch(trainHero({ heroId }));
  }
}
