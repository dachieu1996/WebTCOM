import { ServiceTypePageComponent } from './components/service-type-page/service-type-page.component';
import { ContactUsComponent } from './components/contact-us/contact-us.component';
import { PortfolioComponent } from './components/portfolio/portfolio.component';
import { ServicePageComponent } from './components/service-page/service-page.component';
import { AbousUsComponent } from './components/abous-us/abous-us.component';
import { HomeComponent } from './components/home/home.component';
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'home', component: HomeComponent },
  { path: 'about-us', component: AbousUsComponent },
  { path: 'service', component: ServicePageComponent },
  { path: 'service-type/:id', component: ServiceTypePageComponent },
  { path: 'portfolio', component: PortfolioComponent },
  { path: 'contact-us', component: ContactUsComponent },

  //{ path: 'landing', loadChildren: () => import('./pages/landing/landing.module').then(m => m.LandingModule) },
  //{ path: 'lock-screen', component: LockScreenComponent },
  //{ path: '**', component: NotFoundComponent }
];

export const AppRouting: ModuleWithProviders = RouterModule.forRoot(routes, {
  preloadingStrategy: PreloadAllModules,  // <- comment this line for activate lazy load
  initialNavigation: 'enabled' // for one load page, without reload
  // useHash: true
});
