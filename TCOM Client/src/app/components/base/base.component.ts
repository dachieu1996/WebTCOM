import { Title, Meta } from '@angular/platform-browser';
import { Component, Injector, PLATFORM_ID, Inject } from '@angular/core';
import { TranslateService } from "@ngx-translate/core";
import { isPlatformBrowser } from '@angular/common';

@Component({
  selector: 'app-base',
  templateUrl: './base.component.html',
  styleUrls: ['./base.component.css']
})
export abstract class BaseComponent {
  public translate: TranslateService;
  public languageIdStorage: number;
  public titleService: Title;
  public metaService: Meta;


  constructor(injector: Injector, @Inject(PLATFORM_ID) public platformId: Object) {
    this.translate = injector.get(TranslateService);
    this.titleService = injector.get(Title);
    this.metaService = injector.get(Meta);
    if (isPlatformBrowser(this.platformId)) {
      const language = localStorage.getItem('languageCode');
      this.translate.use(language ? language : 'vi');
      this.languageIdStorage = Number(localStorage.getItem('languageId'));
    }
  }

  l(key: string, ...args: any[]): string {
    return this.translate.instant(key);
  }
}
