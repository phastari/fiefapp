interface ILivingcondition {
  type: LivingconditionType;
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
  constructor(
    public type: LivingconditionType,
    public name: string,
    public baseCost: number,
    public luxuryCost: number,
    public focusGain: number,
    public wellbeingGain: number,
    public description: string
  ) {}
}

export const emptyLivingcondition: Livingcondition = {
  type: LivingconditionType.GOOD,
  name: '',
  baseCost: 0,
  luxuryCost: 0,
  focusGain: 0,
  wellbeingGain: 0,
  description: '',
};
