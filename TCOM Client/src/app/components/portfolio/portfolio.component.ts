import { RouteLink } from './../../core/constants/route-link';
import { Default } from './../../core/constants/default';
import { Project } from './../../core/models/project';
import { ProjectTypeService } from './../../core/services/project-type.service';
import { PortfolioService } from './../../core/services/portfolio.service';
import { Component, OnInit, Injector, PLATFORM_ID, Inject } from '@angular/core';
import { Portfolio } from 'src/app/core/models/portfolio';
import { environment } from 'src/environments/environment';
import { BaseComponent } from '../base/base.component';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-portfolio',
  templateUrl: './portfolio.component.html',
  styleUrls: ['./portfolio.component.scss']
})
export class PortfolioComponent extends BaseComponent implements OnInit {
  baseUrl = environment.BASE_URL;
  porfolio = {} as Project;
  porfolios = [] as Portfolio[];
  languageId: number = Default.languageId;

  constructor(
    injector: Injector,
    @Inject(PLATFORM_ID) public platformId: Object,
    private portfolioService: PortfolioService,
    private projectTypeService: ProjectTypeService,
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
        this.router.navigate([RouteLink.portfolio], { queryParams: { languageId: this.languageIdStorage } });
      });
    }

    this.getData();
  }

  getData(){
    this.getByLanguageId();
    this.getForPage();
  }

  getByLanguageId() {
    this.portfolioService.getByLanguageId(this.languageId).then(res => {
      if (res.data) {
        this.porfolio = res.data;
        this.titleService.setTitle(res.data.title);
        this.metaService.updateTag({ name: 'description', content: res.data.description });
      }
    });
  }

  getForPage() {
    this.projectTypeService.getForPage(this.languageId).then(res => {
      if (res.data) {
        this.porfolios = res.data;
      }
    });
  }

}
