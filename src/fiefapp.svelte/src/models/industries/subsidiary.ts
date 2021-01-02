import { Industry } from './industry';

interface ISubsidiary {
  quality: number;
  developmentLevel: number;
  daysworkThisYear: number;
  incomeFactor: number;
  silverPortion: number;
  basePortion: number;
  luxuryPortion: number;
  daysworkBuild: number;
  daysworkUpkeep: number;
  springModifier: number;
  summerModifier: number;
  fallModifier: number;
  winterModifier: number;
}

export class Subsidiary extends Industry implements ISubsidiary {
  daysworkThisYear: number;
  name: string;
  quality: number;
  developmentLevel: number;
  incomeFactor: number;
  silverPortion: number;
  basePortion: number;
  luxuryPortion: number;
  daysworkBuild: number;
  daysworkUpkeep: number;
  springModifier: number;
  summerModifier: number;
  fallModifier: number;
  winterModifier: number;

  constructor() {
    super();

    this.name = '';
    this.quality = 0;
    this.developmentLevel = 0;
    this.incomeFactor = 0;
    this.silverPortion = 0;
    this.basePortion = 0;
    this.luxuryPortion = 0;
    this.daysworkBuild = 0;
    this.daysworkUpkeep = 0;
    this.springModifier = 0;
    this.summerModifier = 0;
    this.fallModifier = 0;
    this.winterModifier = 0;
    this.needSteward = true;
    this.daysworkThisYear = 0;
    this.silver = 0;
    this.base = 0;
    this.luxury = 0;
  }
}
