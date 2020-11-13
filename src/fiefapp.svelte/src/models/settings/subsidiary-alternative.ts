import { Subsidiary } from '../industries/subsidiary';

interface ISubsidiaryAlternative {
  name: string;
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

export class SubsidiaryAlternative implements ISubsidiaryAlternative {
  constructor(
    public name: string,
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
  ) {}

  public create(): Subsidiary {
    return new Subsidiary(
      this.name,
      0,
      1,
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
