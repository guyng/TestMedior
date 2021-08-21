import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Hero } from "../models/hero.model";

@Injectable({ providedIn: 'root' })
export class HeroService {
  constructor(private _http: HttpClient) {
  }

  public getMyHeroes(): Observable<Hero[]> {
    return this._http.get<any[]>('api/HeroManagement/GetUserHeroes');
  }

  public getAllHeroes(): Observable<Hero[]> {
    return this._http.get<any[]>('api/HeroManagement');
  }

  public trainHero(heroId: number): Observable<Hero> {
    return this._http.put<Hero>('api/HeroManagement/' + heroId, null);
  }
}
