import { Industry } from './industry';

interface IFelling {
  amountLandclearing: number;
  amountLandclearingOfFelling: number;
  amountFelling: number;
  amountClearUseless: number;
}

export class Felling extends Industry implements IFelling {
  amountLandclearing: number;
  amountLandclearingOfFelling: number;
  amountFelling: number;
  amountClearUseless: number;

  constructor() {
    super();
    this.name = 'Skogsavverkning';
    this.needSteward = true;
    this.amountLandclearing = 0;
    this.amountLandclearingOfFelling = 0;
    this.amountFelling = 0;
    this.amountClearUseless = 0;
    this.wood = 0;
  }
}
