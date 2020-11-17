import { writable } from 'svelte/store';
import {
  initialSelectionAlternatives,
  ISelectionAlternatives,
} from '../models/settings/selection-alternatives';

export const selectionAlternatives = writable<ISelectionAlternatives>(
  initialSelectionAlternatives
);
