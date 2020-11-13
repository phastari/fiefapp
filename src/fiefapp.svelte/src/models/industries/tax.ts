import { Industry } from './industry';

export enum TaxType {
  AVERCORN = 'AVERCORN',
  TAX = 'TAX',
  LICENCE_FEE = 'LICENCE_FEE',
  TOLL = 'TOLL',
}

interface ITax {
  taxType: TaxType;
  showInIncomes: boolean;
}

export class Tax extends Industry implements ITax {
  showInIncomes: boolean;

  constructor(public taxType: TaxType) {
    super();
    this.needSteward = false;
    this.taxType = taxType;

    switch (taxType) {
      case TaxType.AVERCORN: {
        this.name = 'Avrad';
        this.base = 0;
        break;
      }

      case TaxType.LICENCE_FEE: {
        this.name = 'Licensavgifter';
        this.silver = 0;
        break;
      }

      case TaxType.TAX: {
        this.name = 'Skatter';
        this.silver = 0;
        break;
      }

      case TaxType.TOLL: {
        this.name = 'Tullar';
        this.silver = 0;
        break;
      }
    }

    this.showInIncomes = true;
  }
}
