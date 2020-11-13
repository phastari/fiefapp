import { SubsidiaryAlternative } from '../settings/subsidiary-alternative';
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

  constructor(
    name: string,
    public quality: number,
    public developmentLevel: number,
    public incomeFactor: number,
    public silverPortion: number,
    public basePortion: number,
    public luxuryPortion: number,
    public daysworkBuild: number,
    public daysworkUpkeep: number,
    public springModifier: number,
    public summerModifier: number,
    public fallModifier: number,
    public winterModifier: number
  ) {
    super();
    this.name = name;
    this.quality = quality;
    this.developmentLevel = developmentLevel;
    this.incomeFactor = incomeFactor;
    this.silverPortion = silverPortion;
    this.basePortion = basePortion;
    this.luxuryPortion = luxuryPortion;
    this.daysworkBuild = daysworkBuild;
    this.daysworkUpkeep = daysworkUpkeep;
    this.springModifier = springModifier;
    this.summerModifier = summerModifier;
    this.fallModifier = fallModifier;
    this.winterModifier = winterModifier;
    this.needSteward = true;
    this.daysworkThisYear = 0;
    this.silver = silverPortion > 0 ? 1000000 : undefined;
    this.base = basePortion > 0 ? 0 : undefined;
    this.luxury = luxuryPortion > 0 ? 0 : undefined;
  }

  public createAlternative(): SubsidiaryAlternative {
    return new SubsidiaryAlternative(
      this.name,
      this.incomeFactor,
      this.silverPortion,
      this.basePortion,
      this.luxuryPortion,
      this.daysworkBuild,
      this.daysworkUpkeep,
      this.springModifier,
      this.summerModifier,
      this.fallModifier,
      this.winterModifier
    );
  }
}
