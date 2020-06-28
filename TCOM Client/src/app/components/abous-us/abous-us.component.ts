import { RouteLink } from './../../core/constants/route-link';
import { Default } from './../../core/constants/default';
import { GalleryService } from './../../core/services/gallery.service';
import { environment } from './../../../environments/environment';
import { Introduction } from './../../core/models/introduction';
import { IntroductionService } from './../../core/services/introduction.service';
import { Component, OnInit, Injector, Inject, PLATFORM_ID } from '@angular/core';
import { BaseComponent } from '../base/base.component';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-abous-us',
  templateUrl: './abous-us.component.html',
  styleUrls: ['./abous-us.component.css']
})
export class AbousUsComponent extends BaseComponent implements OnInit {
  baseUrlImg = environment.BASE_URL;
  imgGallery = [];
  introduction: Introduction = {} as Introduction;
  languageId: number = Default.languageId;

  constructor(
    injector: Injector,
    @Inject(PLATFORM_ID) public platformId: Object,
    private introductionService: IntroductionService,
    private galleryService: GalleryService,
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
        this.router.navigate([RouteLink.introduction], { queryParams: { languageId: this.languageIdStorage } });
      });
    }

    this.getData();
  }

  getData() {
    this.getIntroduction();
    this.getAllImgGallery();
  }

  getIntroduction() {
    this.introductionService.getByLanguageId(this.languageId).then(res => {
      if (res.data)
        this.introduction = res.data;
    });
  }

  getAllImgGallery() {
    this.galleryService.getAll().then(res => {
      if (res.data)
        this.imgGallery = res.data;
    });
  }
}
