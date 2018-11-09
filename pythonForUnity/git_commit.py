import os, sys, glob , time
from git import *

repo = Repo('../')
repo.git.add('--all')
newcommit = repo.index.commit('Regular' + str(time.time()))
origin = repo.remotes.origin
origin.push()

