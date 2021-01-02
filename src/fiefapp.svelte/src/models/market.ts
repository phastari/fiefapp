import type { Development } from './industries/development';

interface IMarket {
  id: string;
  stewardId?: string;
  merchantIds: string[];
  soldierIds: string[];
  name: string;
  developmentLevel: number;
  merchandise: number;
  silver: number;
  base: number;
  luxury: number;
  taxes: number;
  bailiffs: number;
  crime: number;
  development?: Development;
}

export class Market implements IMarket {
  id: string;
  stewardId?: string;
  merchantIds: string[];
  soldierIds: string[];
  name: string;
  developmentLevel: number;
  merchandise: number;
  silver: number;
  base: number;
  luxury: number;
  taxes: number;
  bailiffs: number;
  crime: number;
  development?: Development;

  constructor() {
    this.id = '';
    this.stewardId = undefined;
    this.merchantIds = [];
    this.soldierIds = [];
    this.name = '';
    this.developmentLevel = 1;
    this.merchandise = 0;
    this.silver = 0;
    this.base = 0;
    this.luxury = 0;
    this.taxes = 0;
    this.bailiffs = 0;
    this.crime = 0;
    this.development = undefined;
  }
}
