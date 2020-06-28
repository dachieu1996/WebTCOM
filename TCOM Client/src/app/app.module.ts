import { ServiceTypePageComponent } from './components/service-type-page/service-type-page.component';
import { HeaderComponent } from './shared/components/header/header.component';
import { FooterComponent } from './shared/components/footer/footer.component';
import { AbousUsComponent } from './components/abous-us/abous-us.component';
import { PortfolioComponent } from './components/portfolio/portfolio.component';
import { ContactUsComponent } from './components/contact-us/contact-us.component';
import { ServicePageComponent } from './components/service-page/service-page.component';
import { HomeComponent } from './components/home/home.component';
import { BrowserModule } from '@angular/platform-browser';
import { TransferHttpModule } from '@gorniv/ngx-universal';
import { TransferState } from '@angular/platform-browser';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { AppRouting } from './app.routing';
import { AppComponent } from './app.component';
import { MenuComponent } from './shared/components/menu/menu.component';
import { SafePipe } from './core/pipe/safe.pipe';
import {TranslateHttpLoader} from '@ngx-translate/http-loader';

export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http);
}

@NgModule({
  declarations: [
    AppComponent,
    //Share
    MenuComponent,
    HeaderComponent,
    FooterComponent,
    //Component
    HomeComponent,
    ServicePageComponent,
    ContactUsComponent,
    PortfolioComponent,
    AbousUsComponent,
    ServiceTypePageComponent,
    SafePipe
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'serverApp' }),
    AppRouting,
    TransferHttpModule,
    HttpClientModule,
    TranslateModule.forRoot({
      loader: {
          provide: TranslateLoader,
          useFactory: HttpLoaderFactory,
          deps: [HttpClient]
      }
  })
  ],
  providers: [
    TransferState
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
