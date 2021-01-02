import type { IPerson } from './person';

interface ISoldier {
  merchantId?: string;
  boatId?: string;
  marketId?: string;
  portId?: string;
  roadId?: string;
  mineId?: string;
  quarryId?: string;
  isResident: boolean;
  type: SoldierType;
  displayName: string;
  silverCost: number;
  baseCost: number;
}

export enum SoldierType {
  UNDEFINED = 0,
  ARMY_CROSSBOWMEN = 1,
  ARMY_BOWMEN = 2,
  ARMY_MEDICS = 3,
  ARMY_MEDICS_SKILLED = 4,
  ARMY_INFANTRY = 5,
  ARMY_INFANTRY_MEDIUM = 6,
  ARMY_INFANTRY_HEAVY = 7,
  ARMY_INFANTRY_ELITE = 8,
  ARMY_LONGBOWMEN = 9,
  ARMY_MERCENARIES = 10,
  ARMY_MERCENARIES_ELITE = 11,
  ARMY_MERCENARIES_BOWMEN = 12,
  ARMY_ENGINEERS = 13,
  ARMY_SPEARMEN = 14,
  ARMY_SCOUTS = 15,
  ARMY_SCOUTS_SKILLED = 16,
  ARMY_KNIGHT_TEMPLARS = 17,
  ARMY_GUARDS = 18,
  ARMY_WEAPONMASTERS = 19,
  CAVALRY_BOWMEN = 20,
  CAVALRY_COURIER = 21,
  CAVALRY_LIGHT = 22,
  CAVALRY_KNIGHTS = 23,
  CAVALRY_SCOUTS = 24,
  CAVALRY_KNIGHT_TEMPLARS = 25,
  CAVALRY_HEAVY = 26,
  CAVALRY_ELITE = 27,
  OFFICER_CORPORAL = 28,
  OFFICER_SERGEANT = 29,
  OFFICER_CAPTAIN = 30,
}

export class Soldier implements ISoldier, IPerson {
  id: string;
  name: string;
  skill: number;
  resources: number;
  loyalty: number;
  age: number;
  merchantId?: string;
  boatId?: string;
  marketId?: string;
  portId?: string;
  roadId?: string;
  mineId?: string;
  quarryId?: string;
  isResident: boolean;
  type: SoldierType;
  displayName: string;
  silverCost: number;
  baseCost: number;

  constructor() {
    this.id = '';
    this.name = '';
    this.skill = 0;
    this.resources = 0;
    this.loyalty = 0;
    this.age = 0;
    this.merchantId = undefined;
    this.boatId = undefined;
    this.marketId = undefined;
    this.portId = undefined;
    this.roadId = undefined;
    this.mineId = undefined;
    this.quarryId = undefined;
    this.isResident = false;
    this.type = SoldierType.ARMY_GUARDS;
    this.displayName = 'Vakt';
    this.silverCost = 0;
    this.baseCost = 0;
  }
}
