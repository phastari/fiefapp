interface ILivingcondition {
  id: string;
  type: LivingconditionType | undefined;
  name: string;
  baseCost: number;
  luxuryCost: number;
  focusGain: number;
  wellbeingGain: number;
  description: string;
}

export enum LivingconditionType {
  BARE = 'BARE',
  MEAGRE = 'MEAGRE',
  GOOD = 'GOOD',
  PLENTIFUL = 'PLENTIFUL',
  LUXURY = 'LUXURY',
}

export class Livingcondition implements ILivingcondition {
  id: string;
  type: LivingconditionType | undefined;
  name: string;
  baseCost: number;
  luxuryCost: number;
  focusGain: number;
  wellbeingGain: number;
  description: string;

  constructor(
    id?: string,
    type?: LivingconditionType,
    name?: string,
    baseCost?: number,
    luxuryCost?: number,
    focusGain?: number,
    wellbeingGain?: number,
    description?: string
  ) {
    this.id = id ? id : '';
    this.type = type ? type : undefined;
    this.name = name ? name : '';
    this.baseCost = baseCost ? baseCost : 0;
    this.luxuryCost = luxuryCost ? luxuryCost : 0;
    this.focusGain = focusGain ? focusGain : 0;
    this.wellbeingGain = wellbeingGain ? wellbeingGain : 0;
    this.description = description ? description : '';
  }
}
