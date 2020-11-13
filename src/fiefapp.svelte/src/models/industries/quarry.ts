import { Industry } from './industry';

export enum QuarrySize {
  SMALL = 'SMALL',
  MEDIUM = 'MEDIUM',
  LARGE = 'LARGE',
  HUGE = 'HUGE',
}

interface IQuarry {
  baseStoneProduction: number;
  soldiers: string[];
  quarrySize: QuarrySize;
  guards: number;
  populationModifier: number;
}

export class Quarry extends Industry implements IQuarry {
  soldiers: string[];
  guards: number;

  constructor(
    public quarrySize: QuarrySize,
    public baseStoneProduction: number,
    public populationModifier: number
  ) {
    super();
    this.needSteward = true;
    this.quarrySize = quarrySize;
    this.baseStoneProduction = baseStoneProduction;
    this.populationModifier = populationModifier;
    switch (quarrySize) {
      case QuarrySize.SMALL: {
        this.name = 'Litet stenbrott';
        break;
      }

      case QuarrySize.MEDIUM: {
        this.name = 'Medelstort stenbrott';
        break;
      }

      case QuarrySize.LARGE: {
        this.name = 'Stort stenbrott';
        break;
      }

      case QuarrySize.HUGE: {
        this.name = 'Enormt stenbrott';
        break;
      }
    }

    this.stone = 0;
    this.soldiers = [];
    this.guards = 0;
  }
}
