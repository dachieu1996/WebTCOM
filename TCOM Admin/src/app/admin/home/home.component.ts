import { LanguageService } from './../../core/services/language.service';
import { HomeService } from './../../core/services/home.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  dataLanguage = [];
  constructor(private homeService: HomeService,
              private languageService: LanguageService) { }

  ngOnInit() {
    this.getAllLanguage()
  }
  
  getAllLanguage(){
    this.languageService.getAll().then(res => {
      this.dataLanguage = res.data;
    });
  }
}
