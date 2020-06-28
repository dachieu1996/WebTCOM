import { Default } from './../../core/constants/default';
import { RouteLink } from './../../core/constants/route-link';
import { ProgrammingLanguageService } from './../../core/services/programming-language.service';
import { ServiceTypeDetailService } from './../../core/services/service-type-detail.service';
import { PartnerService } from './../../core/services/partner.service';
import { Home } from './../../core/models/home';
import { environment } from './../../../environments/environment';
import { HomeService } from './../../core/services/home.service';
import { Title, Meta } from '@angular/platform-browser';
import { Component, OnInit, ViewChild, Injector, Inject, PLATFORM_ID } from '@angular/core';
import { BaseComponent } from '../base/base.component';
import { ServiceTypeDetail } from 'src/app/core/models/service-type-detail';
import { Router, ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent extends BaseComponent implements OnInit {
  imgPartners = [];
  programmingLanguages: string[] = [];
  baseUrl = environment.BASE_URL;
  home: Home = {} as Home;
  serviceTypeDetails: ServiceTypeDetail[] = [] as ServiceTypeDetail[];
  languageId: number = Default.languageId;

  constructor(
    injector: Injector,
    @Inject(PLATFORM_ID) public platformId: Object,
    private homeService: HomeService,
    private partnerService: PartnerService,
    private serviceTypeDetailService: ServiceTypeDetailService,
    private programmingLanguageService: ProgrammingLanguageService,
    private router: Router,
    private route: ActivatedRoute
  ) {
    super(injector, platformId);
  }

  ngOnInit() {
    let languageIdParam = this.route.snapshot.queryParamMap.get('languageId');
    if (languageIdParam) {
      this.languageId = Number(languageIdParam);
    }
    else if (this.languageIdStorage && this.languageIdStorage != Default.languageId) {
      this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
        this.router.navigate([RouteLink.home], { queryParams: { languageId: this.languageIdStorage } })
      });
    }

    this.getData();
  }

  getData() {
    this.getHome();
    this.getServiceTypeDetail();
    this.getImgPartner();
    this.getProgrammingLanguage();
  }

  getProgrammingLanguage() {
    this.programmingLanguageService.getForHome().then(res => {
      this.programmingLanguages = res.data;
    })
  }

  getHome() {
    this.homeService.getByLanguageId(this.languageId).then(res => {
      if (res.data) {
        this.home = res.data;
        this.titleService.setTitle(res.data.title);
        this.metaService.updateTag({ name: 'description', content: res.data.description });
      }
    });
  }

  getServiceTypeDetail() {
    this.serviceTypeDetailService.getByLanguageId(this.languageId).then(res => {
      if (res.data) {
        this.serviceTypeDetails = res.data;
      }
    })
  }

  getImgPartner() {
    this.partnerService.getAll().then(res => {
      if (res.data) {
        this.imgPartners = res.data;
      }
    });
  }
}
