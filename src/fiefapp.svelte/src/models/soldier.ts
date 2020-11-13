import { v4 as uuidv4 } from 'uuid';

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
  ARMY_CROSSBOWMEN = 'ARMY_CROSSBOWMEN',
  ARMY_BOWMEN = 'ARMY_BOWMEN',
  ARMY_MEDICS = 'ARMY_MEDICS',
  ARMY_MEDICS_SKILLED = 'ARMY_MEDICS_SKILLED',
  ARMY_INFANTRY = 'ARMY_INFANTRY',
  ARMY_INFANTRY_MEDIUM = 'ARMY_INFANTRY_MEDIUM',
  ARMY_INFANTRY_HEAVY = 'ARMY_INFANTRY_HEAVY',
  ARMY_INFANTRY_ELITE = 'ARMY_INFANTRY_ELITE',
  ARMY_LONGBOWMEN = 'ARMY_LONGBOWMEN',
  ARMY_MERCENARIES = 'ARMY_MERCENARIES',
  ARMY_MERCENARIES_ELITE = 'ARMY_MERCENARIES_ELITE',
  ARMY_MERCENARIES_BOWMEN = 'ARMY_MERCENARIES_BOWMEN',
  ARMY_ENGINEERS = 'ARMY_ENGINEERS',
  ARMY_SPEARMEN = 'ARMY_SPEARMEN',
  ARMY_SCOUTS = 'ARMY_SCOUTS',
  ARMY_SCOUTS_SKILLED = 'ARMY_SCOUTS_SKILLED',
  ARMY_KNIGHT_TEMPLARS = 'ARMY_KNIGHT_TEMPLARS',
  ARMY_GUARDS = 'ARMY_GUARDS',
  ARMY_WEAPONMASTERS = 'ARMY_WEAPONMASTERS',
  CAVALRY_BOWMEN = 'CAVALRY_BOWMEN',
  CAVALRY_COURIER = 'CAVALRY_COURIER',
  CAVALRY_LIGHT = 'CAVALRY_LIGHT',
  CAVALRY_KNIGHTS = 'CAVALRY_KNIGHTS',
  CAVALRY_SCOUTS = 'CAVALRY_SCOUTS',
  CAVALRY_KNIGHT_TEMPLARS = 'CAVALRY_KNIGHT_TEMPLARS',
  CAVALRY_HEAVY = 'CAVALRY_HEAVY',
  CAVALRY_ELITE = 'CAVALRY_ELITE',
  OFFICER_CORPORAL = 'OFFICER_CORPORAL',
  OFFICER_SERGEANT = 'OFFICER_SERGEANT',
  OFFICER_CAPTAIN = 'OFFICER_CAPTAIN',
}

export class Soldier implements ISoldier, IPerson {
  readonly id: string;
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
    this.id = uuidv4();
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
