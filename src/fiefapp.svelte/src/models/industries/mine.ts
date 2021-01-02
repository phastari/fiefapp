import { Industry } from './industry';

export enum MineType {
  UNDEFINED = 0,
  TIN = 1,
  IRON = 2,
  COPPER = 3,
  SILVER = 4,
  GOLD = 5,
  GEMS = 6,
  CUSTOM = 7,
}

interface IMine {
  soldiers: string[];
  mineType: MineType;
  yearsLeft: number;
  baseSilverProduction: number;
  populationModifier: number;
}

export class Mine extends Industry implements IMine {
  soldiers: string[];
  yearsLeft: number;
  mineType: MineType;
  baseSilverProduction: number;
  populationModifier: number;

  constructor() {
    super();

    this.needSteward = true;
    this.soldiers = [];
    this.yearsLeft = 0;
    this.silver = 0;
    this.baseSilverProduction = 0;
    this.mineType = MineType.UNDEFINED;
    this.populationModifier = 0;
  }
}
