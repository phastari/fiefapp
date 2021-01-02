import { Industry } from './industry';

export enum IncomeType {
  UNDEFINED = 0,
  AGRICULTURAL = 1,
  ANIMAL_HUSBANDRY = 2,
  FISHING = 3,
  HUNTING = 4,
}

interface IIncome {
  incomeType: IncomeType;
  showInIncomes: boolean;
  springModifier: number;
  summerModifier: number;
  fallModifier: number;
  winterModifier: number;
}

export class Income extends Industry implements IIncome {
  showInIncomes: boolean;
  incomeType: IncomeType;
  springModifier: number;
  summerModifier: number;
  fallModifier: number;
  winterModifier: number;

  constructor() {
    super();
    this.incomeType = IncomeType.UNDEFINED;
    this.showInIncomes = true;
    this.springModifier = 0;
    this.summerModifier = 0;
    this.fallModifier = 0;
    this.winterModifier = 0;
  }
}
