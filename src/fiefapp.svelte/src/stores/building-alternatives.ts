import { writable } from 'svelte/store';
import type { BuildingAlternative } from '../models/settings/building-alternative';

export const buildingAlternatives = writable<BuildingAlternative[]>([]);
