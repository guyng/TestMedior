import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FlexLayoutModule } from "@angular/flex-layout";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { MatButtonModule, MatCardModule, MatDatepickerModule, MatFormFieldModule, MatInputModule, MatListModule, MatProgressBarModule } from "@angular/material";
import { MatMomentDateModule } from "@angular/material-moment-adapter";
import { RouterModule } from "@angular/router";
import { AuthorizeGuard } from "src/api-authorization/authorize.guard";
import { SharedStoreModule } from "../shared/store/store.module";
import { HeroCardComponent } from "./hero-card/hero-card.component";
import { HeroesManagementComponent } from "./heroes-management/heroes-management.component";

const routes = [
  {
    path: 'management',
    component: HeroesManagementComponent,
    canActivate: [AuthorizeGuard]
  }
];

@NgModule({
  declarations: [HeroesManagementComponent,
    HeroCardComponent
  ],
  imports: [
    RouterModule.forChild(routes),
    CommonModule,
    SharedStoreModule,
    MatProgressBarModule,
    MatFormFieldModule,
    MatDatepickerModule,
    ReactiveFormsModule,
    MatListModule,
    FormsModule,
    MatMomentDateModule,
    MatButtonModule,
    MatInputModule,
    FlexLayoutModule,
    MatCardModule,
  ],
  providers: []
})
export class HeroesModule {
}
