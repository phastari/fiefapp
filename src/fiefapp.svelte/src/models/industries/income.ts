import { Industry } from './industry';

export enum IncomeType {
  AGRICULTURAL = 'AGRICULTURAL',
  ANIMAL_HUSBANDRY = 'ANIMAL_HUSBANDRY',
  FISHING = 'FISHING',
  HUNTING = 'HUNTING',
}

interface IIncome {
  incomeType: IncomeType;
  showInIncome: boolean;
  springModifier: number;
  summerModifier: number;
  fallModifier: number;
  winterModifier: number;
}

export class Income extends Industry implements IIncome {
  showInIncome: boolean;

  constructor(
    public incomeType: IncomeType,
    public springModifier: number,
    public summerModifier: number,
    public fallModifier: number,
    public winterModifier: number
  ) {
    super();
    switch (incomeType) {
      case IncomeType.AGRICULTURAL: {
        this.name = 'Jordbruk';
        break;
      }

      case IncomeType.ANIMAL_HUSBANDRY: {
        this.name = 'Djurhållning';
        break;
      }

      case IncomeType.FISHING: {
        this.name = 'Fiske';
        break;
      }

      case IncomeType.HUNTING: {
        this.name = 'Jakt';
        break;
      }
    }

    this.needSteward = true;
    this.incomeType = incomeType;
    this.springModifier = springModifier;
    this.summerModifier = summerModifier;
    this.fallModifier = fallModifier;
    this.winterModifier = winterModifier;
    this.showInIncome = true;
    this.base = 0;
  }
}
