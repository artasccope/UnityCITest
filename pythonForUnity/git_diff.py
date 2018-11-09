import os, sys, glob
from git import *

repo = Repo('../')
index = repo.index
index.add(repo.untracked_files)
newcommit = index.commit('Regular')
origin = repo.remotes.origin
origin.push()

