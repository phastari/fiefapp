import { Industry } from './industry';
import { rollObt6 } from '../../utils/dice-rolls/obt6';

export enum MineType {
  TIN = 'TIN',
  IRON = 'IRON',
  COPPER = 'COPPER',
  SILVER = 'SILVER',
  GOLD = 'GOLD',
  GEMS = 'GEMS',
  CUSTOM = 'CUSTOM',
}

interface IMine {
  soldiers: string[];
  mineType: MineType;
  yearsLeft: number;
  guards: number;
  baseSilverProduction: number;
  populationModifier: number;
}

export class Mine extends Industry implements IMine {
  soldiers: string[];
  yearsLeft: number;
  guards: number;

  constructor(
    public mineType: MineType,
    public baseSilverProduction: number,
    public populationModifier: number
  ) {
    super();
    switch (mineType) {
      case MineType.TIN: {
        this.name = 'Tenngruva';
        break;
      }

      case MineType.IRON: {
        this.name = 'Järngruva';
        break;
      }

      case MineType.COPPER: {
        this.name = 'Koppargruva';
        break;
      }

      case MineType.SILVER: {
        this.name = 'Silvergruva';
        break;
      }

      case MineType.GOLD: {
        this.name = 'Guldgruva';
        break;
      }

      case MineType.GEMS: {
        this.name = 'Ädelstensgruva';
        break;
      }

      case MineType.CUSTOM: {
        this.name = 'Valfrigruva';
        break;
      }
    }

    this.needSteward = true;
    this.soldiers = [];
    this.yearsLeft = rollObt6(1).total * rollObt6(2).total;
    this.guards = 0;
    this.silver = 0;
    this.baseSilverProduction = baseSilverProduction;
    this.mineType = mineType;
    this.populationModifier = populationModifier;
  }
}
