import { ServiceSubDetail } from './service-sub-detail';
import { Experties } from './experties';
export interface ServiceTypeDetail {
  id: number;
  title: string;
  description: string;
  mainHeader: string;
  mainContent: string;
  expertiseHeader: string;
  expertiseContent: string;
  imgUrl: string;
  smallImgUrl: string;
  iconUrl: string;
  languageId: number;
  serviceTypeId: number;
  expertises: Experties[];
  serviceSubDetails: ServiceSubDetail[];
}
