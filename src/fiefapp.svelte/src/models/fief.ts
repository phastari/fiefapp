import { v4 as uuidv4 } from 'uuid';

import { Market } from './market';
import { Livingcondition, livingconditions } from './livingcondition';
import type { Port } from './port';
import { Road, roads } from './road';
import { Inheritance, inheritances } from './inheritance';
import { Village } from './village';
import type { Building } from './building';
import type { Boat } from './boat';
import type { Resident } from './resident';
import type { Soldier } from './soldier';
import type { Employee } from './employee';
import type { Builder } from './builder';
import type { Industry } from './industries/industry';
import { getDefaultIndustries } from '../static/default-industries';

interface IFief {
  fiefId: string;
  name: string;
  manorName: string;
  acres: number;
  farmlandAcres: number;
  pastureAcres: number;
  woodlandAcres: number;
  fellingAcres: number;
  unusableAcres: number;
  animalHusbandryQuality: number;
  agriculturalQuality: number;
  fishingQuality: number;
  oreQuality: number;
  huntingQuality: number;
  animalHusbandryDevelopmentLevel: number;
  agriculturalDevelopmentLevel: number;
  fishingDevelopmentLevel: number;
  woodlandDevelopmentLevel: number;
  oreDevelopmentLevel: number;
  huntingDevelopmentLevel: number;
  educationDevelopmentLevel: number;
  healthcareDevelopmentLevel: number;
  militaryDevelopmentLevel: number;
  seafaringDevelopmentLevel: number;
  market?: Market;
  stewardId?: string;
  port?: Port;
  livingcondition: Livingcondition;
  road: Road;
  inheritance: Inheritance;
  villages: Village[];
  industries: Industry[];
  buildings: Building[];
  boats: Boat[];
  residents: Resident[];
  soldiers: Soldier[];
  employees: Employee[];
  builders: Builder[];
}

export interface IFiefs {
  fiefs: IFief[];
}

export interface IShortFief {
  fiefId: string;
  name: string;
}

export class Fief implements IFief {
  readonly fiefId: string;
  name: string;
  manorName: string;
  acres: number;
  farmlandAcres: number;
  pastureAcres: number;
  woodlandAcres: number;
  fellingAcres: number;
  unusableAcres: number;
  animalHusbandryQuality: number;
  agriculturalQuality: number;
  fishingQuality: number;
  oreQuality: number;
  huntingQuality: number;
  animalHusbandryDevelopmentLevel: number;
  agriculturalDevelopmentLevel: number;
  fishingDevelopmentLevel: number;
  woodlandDevelopmentLevel: number;
  oreDevelopmentLevel: number;
  huntingDevelopmentLevel: number;
  educationDevelopmentLevel: number;
  healthcareDevelopmentLevel: number;
  militaryDevelopmentLevel: number;
  seafaringDevelopmentLevel: number;
  market?: Market;
  stewardId?: string;
  port?: Port;
  livingcondition: Livingcondition;
  road: Road;
  inheritance: Inheritance;
  villages: Village[];
  industries: Industry[];
  buildings: Building[];
  boats: Boat[];
  residents: Resident[];
  soldiers: Soldier[];
  employees: Employee[];
  builders: Builder[];

  constructor(name: string = '') {
    this.fiefId = uuidv4();
    if (name === '') {
      this.name = 'Ny förläning';
    } else {
      this.name = name;
    }
    this.manorName = 'Ny förlänings gods';
    this.acres = 0;
    this.farmlandAcres = 0;
    this.pastureAcres = 0;
    this.woodlandAcres = 0;
    this.fellingAcres = 0;
    this.unusableAcres = 0;
    this.animalHusbandryQuality = 1;
    this.agriculturalQuality = 1;
    this.fishingQuality = 1;
    this.oreQuality = 1;
    this.huntingQuality = 1;
    this.animalHusbandryDevelopmentLevel = 1;
    this.agriculturalDevelopmentLevel = 1;
    this.fishingDevelopmentLevel = 1;
    this.woodlandDevelopmentLevel = 1;
    this.oreDevelopmentLevel = 1;
    this.huntingDevelopmentLevel = 1;
    this.educationDevelopmentLevel = 1;
    this.healthcareDevelopmentLevel = 1;
    this.militaryDevelopmentLevel = 1;
    this.seafaringDevelopmentLevel = 1;
    this.market = new Market();
    this.stewardId = undefined;
    this.port = undefined;
    this.livingcondition = livingconditions[2];
    this.road = roads[1];
    this.inheritance = inheritances[0];
    this.villages = [new Village()];
    this.industries = getDefaultIndustries(this.fiefId, this.market.marketId);
    this.buildings = [];
    this.boats = [];
    this.residents = [];
    this.soldiers = [];
    this.employees = [];
    this.builders = [];
  }
}
