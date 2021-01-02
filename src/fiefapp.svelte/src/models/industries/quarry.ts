import { Industry } from './industry';

export enum QuarryType {
  UNDEFINED = 0,
  SMALL = 1,
  MEDIUM = 2,
  LARGE = 3,
  HUGE = 4,
}

interface IQuarry {
  baseStoneProduction: number;
  soldiers: string[];
  quarrySize: QuarryType;
  guards: number;
  populationModifier: number;
}

export class Quarry extends Industry implements IQuarry {
  soldiers: string[];
  guards: number;

  constructor(
    public quarrySize: QuarryType,
    public baseStoneProduction: number,
    public populationModifier: number
  ) {
    super();
    this.needSteward = true;
    this.quarrySize = quarrySize;
    this.baseStoneProduction = baseStoneProduction;
    this.populationModifier = populationModifier;
    switch (quarrySize) {
      case QuarryType.SMALL: {
        this.name = 'Litet stenbrott';
        break;
      }

      case QuarryType.MEDIUM: {
        this.name = 'Medelstort stenbrott';
        break;
      }

      case QuarryType.LARGE: {
        this.name = 'Stort stenbrott';
        break;
      }

      case QuarryType.HUGE: {
        this.name = 'Enormt stenbrott';
        break;
      }
    }

    this.stone = 0;
    this.soldiers = [];
    this.guards = 0;
  }
}
