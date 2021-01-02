import { Industry } from './industry';

export enum TaxType {
  UNDEFINED = 0,
  AVERCORN = 1,
  TAX = 2,
  LICENSE = 3,
  TOLL = 4,
}

interface ITax {
  taxType: TaxType;
  showInIncomes: boolean;
}

export class Tax extends Industry implements ITax {
  showInIncomes: boolean;
  taxType: TaxType;

  constructor() {
    super();

    this.needSteward = false;
    this.taxType = TaxType.UNDEFINED;
    this.showInIncomes = true;
  }
}
