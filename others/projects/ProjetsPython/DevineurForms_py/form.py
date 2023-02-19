from tkinter import *
import tkinter as tk
import random
import list_of_words

liste = list_of_words.listdemots

# =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#   -   -   -   Fonctions   -   -   -   -   -   -   -   -   - 
# =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

# prend un mot au hasard dans la liste en paramètre
def mot_aleatoire(list = liste):
    return random.choice(list)

# mélange les lettres du mot en paramètre
def melanger_mot(mot):
    mot_m = list(mot)
    random.shuffle(mot_m)
    return ''.join(mot_m)

# compare la solution proposée par le joueur avec le mot à trouver
def tester():
    test = mot_test.get().upper()
    soluce = mot_soluce.get()
    if soluce == test:
        mot_soluce_melange.configure(text="Félicitation! Vous avez trouvé!")
        mot_test.config(state="disabled")
    else :
        cpt = int(cpt_erreurs.get()) +1
        cpt_erreurs.set(str(cpt))
        pluriel = '' if cpt == 1 else 's'
        text_cpt_erreurs.configure(text="Vous avez fait " + str(cpt) + " tentative" + pluriel)
        vidange()
    mot_test.delete(0, END)

# lance une nouvelle partie
def rejouer():
    mot_test.config(state="normal")
    mot_test.delete(0, END)
    vidange(False)
    text_cpt_erreurs.configure(text="Vous avez fait 0 tentative")
    mot = mot_aleatoire()
    mot_soluce.set(mot)
    mot_soluce_melange.configure(text=melanger_mot(mot))
    
# vide la liste des mauvaises réponces
def vidange(ajout=True):
    text = "Vous avez déjà essayé :\n"
    list_erreurs.config(state="normal")
    if ajout == True:
        text = '- ' + mot_test.get() + "\n"
    else :
        list_erreurs.delete("1.0", tk.END)
    list_erreurs.insert(tk.END, text)
    list_erreurs.config(state="disabled")


# =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#   -   -   -   fenêtre de jeu  -   -   -   -   -   -   -   -
# =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

# Création de la fenêtre principale
fenetre = tk.Tk()
sous_fenetre = tk.Frame(fenetre)
sous_fenetre2 = tk.Frame(sous_fenetre)

# Définition du titre de la fenêtre
fenetre.title("Jeu MotATrouver")

#le premier mot demandé
solution = mot_aleatoire(liste)
mot_melange = melanger_mot(solution)

# le mot à deviner
mot_soluce = tk.StringVar()
mot_soluce.set(solution)
mot_soluce_melange = tk.Label(fenetre, width=40, text=mot_melange)

# la boîte où le joueur entre ses propositions
mot_test = tk.Entry(fenetre, width=40, bd=2)

# le nombre d'erreur en texte
cpt_erreurs = tk.StringVar()
cpt_erreurs.set("0")
cpt = cpt_erreurs.get()
text_cpt_erreurs = tk.Label(sous_fenetre, width=40, text="Vous avez fait 0 tentative")

# la boîte des mauvaises réponce
scroll = tk.Scrollbar(fenetre)
list_erreurs = tk.Text(fenetre, width=30, height=3, bd=2, wrap="word", yscrollcommand=scroll.set)
list_erreurs.insert(tk.END, "Vous avez déjà essayé :\n")
list_erreurs.config(state="disabled")
scroll.config(command=list_erreurs.yview)

# les boutons
test_button = tk.Button(sous_fenetre2, text="Tester", command=tester)
replay_button = tk.Button(sous_fenetre2, text="Rejouer", command=rejouer)

# placement des éléments dans la fenetre
# colonne 1
mot_soluce_melange.grid (row=0, column=0, padx=10, pady=10)
list_erreurs.grid       (row=1, column=0, padx=10, pady=10)
# colonne 2
mot_test.grid           (row=0, column=1, padx=10, pady=10)
sous_fenetre.grid       (row=1, column=1)

# placement des éléments dans la sous_fenetre
text_cpt_erreurs.pack()
sous_fenetre2.pack()

test_button.pack        (side="left", padx=10, pady=10)
replay_button.pack      (side="right", padx=10, pady=10)

# Boucle principale de l'interface utilisateur
fenetre.mainloop()
