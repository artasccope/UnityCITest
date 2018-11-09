import os, sys, glob
from git import *

repo = Repo('../')

hcommit = repo.commit('master')

print(hcommit.name_rev)

diff_index = hcommit.diff('HEAD~1')

print('added commit:')
for diff_added in diff_index.iter_change_type('A'):
    print(diff_added)

print('modified commit:')
for diff_modified in diff_index.iter_change_type('M'):
    print(diff_modified)

print('renamed commit:')
for diff_r in diff_index.iter_change_type('R'):
    print(diff_r)

#......


