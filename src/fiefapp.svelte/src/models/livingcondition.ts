import { v4 as uuidv4 } from 'uuid';

interface ILivingcondition {
  livingconditionId: string;
  type: LivingconditionType;
  baseCost: number;
  luxuryCost: number;
  focusGain: number;
  wellbeing: number;
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
  readonly livingconditionId: string;
  type: LivingconditionType;
  baseCost: number;
  luxuryCost: number;
  focusGain: number;
  wellbeing: number;
  description: string;

  constructor(
    type: LivingconditionType,
    baseCost: number,
    luxuryCost: number,
    focusGain: number,
    wellbeing: number,
    description: string
  ) {
    this.livingconditionId = uuidv4();
    this.type = type;
    this.baseCost = baseCost;
    this.luxuryCost = luxuryCost;
    this.focusGain = focusGain;
    this.wellbeing = wellbeing;
    this.description = description;
  }
}

export const livingconditions: Livingcondition[] = [
  new Livingcondition(LivingconditionType.BARE, 1, 0, -4, -2, 'Nödtorftig'),
  new Livingcondition(LivingconditionType.MEAGRE, 2, 0, -2, -1, 'Gemen'),
  new Livingcondition(LivingconditionType.GOOD, 3, 2, 2, 1, 'God'),
  new Livingcondition(LivingconditionType.PLENTIFUL, 4, 4, 6, 2, 'Mycket god'),
  new Livingcondition(LivingconditionType.LUXURY, 6, 8, 10, 3, 'Lyxliv'),
];
