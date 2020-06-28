import { Default } from './../../../core/constants/default';
import { isPlatformBrowser } from '@angular/common';
import { Language } from './../../../core/models/language';
import { BaseComponent } from './../../../components/base/base.component';
import { environment } from './../../../../environments/environment';
import { LanguageService } from './../../../core/services/language.service';
import { Component, OnInit, NgModule, Output, Injector, Inject, PLATFORM_ID } from '@angular/core';
import { Menu } from './menu';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent extends BaseComponent implements OnInit {
  menuItems: Array<Menu> = [];
  baseUrl: string = environment.BASE_URL;

  dataLanguage: Language[] = [];
  selectedLanguageId: number = Default.languageId;
  constructor(
    injector: Injector,
    @Inject(PLATFORM_ID) public platformId: Object,
    private languageService: LanguageService,
    private router: Router
  ) {
    super(injector, platformId);
  }

  ngOnInit() {
    this.initMenuItem();
    this.getLocalLanguage();
    this.getAllLanguage();
  }

  initMenuItem() {
    this.menuItems = [
      new Menu(1, 'menu.home', '/home', null, null, false, 0),
      new Menu(2, 'menu.introduction', '/about-us', null, null, false, 0),
      new Menu(3, 'menu.service', '/service', null, null, false, 0),
      new Menu(4, 'menu.project', '/portfolio', null, null, false, 0),
      new Menu(5, 'menu.contact', '/contact-us', null, null, false, 0),
    ];
  }

  getLocalLanguage() {
    if (isPlatformBrowser(this.platformId)) {
      if (localStorage.getItem(environment.languageId))
        this.selectedLanguageId = Number(localStorage.getItem(environment.languageId));
    }
  }

  async getAllLanguage() {
    await this.languageService.getAll().then(res => {
      this.dataLanguage = res.data;
    });
  }
  saveLocalStorage(language) {
    if (isPlatformBrowser(this.platformId)) {
      localStorage.setItem(environment.languageId, language.id);
      localStorage.setItem(environment.languageCode, language.code);
      this.router.navigate([this.router.url.split("?")[0]], { queryParams: { languageId: language.id } }).then(() => {
        window.location.reload();
      });
    }
  }

}
